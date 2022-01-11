using Allup.Areas.Admin.ViewModels;
using Allup.Data;
using Allup.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_proj.Areas.Admin.Constants;
using MVC_proj.Areas.Admin.Utilis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            return View(categories);
        }

        //***** Detail *****//
        public async Task<IActionResult> Detail(int id)
        {
            var category = await _context.Categories.Include(c => c.Children).FirstOrDefaultAsync(c => c.Id == id);
            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }


        //***** Create *****//
        public async Task<IActionResult> Create()
        {
            var parents = await _context.Categories.Where(c => c.IsMain && !c.IsDeleted).ToListAsync();
            ViewBag.Parents = parents;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoryCreateViewModel model)
        {
            var parents = await _context.Categories.Where(c => c.IsMain && !c.IsDeleted).ToListAsync();
            ViewBag.Parents = parents;

            if (!ModelState.IsValid)
            {
                return View();
            }

            if(model.IsMain)
            {
                if(model.File == null)
                {
                    ModelState.AddModelError("File", "Select an image");
                    return View();
                }
                if(!model.File.IsSupported())
                {
                    ModelState.AddModelError("File", "File is unsupported");
                    return View();
                }
                if(model.File.IsGreaterThanGivenSize(1024))
                {
                    ModelState.AddModelError(nameof(model.File), "File size cannot be greater than 1 mb");
                    return View();
                }

                var imageName = FileUtil.CreatedFile(FileConstants.ImagePath, model.File);

                Category category = new Category
                {
                    Name = model.Name,
                    Image = imageName,
                    IsMain = model.IsMain
                };

                await _context.Categories.AddAsync(category);
            }
            else
            {
                var parent = await _context.Categories.FirstOrDefaultAsync(c => c.IsMain && !c.IsDeleted && c.Id == model.ParentId);
                if(parent == null)
                {
                    ModelState.AddModelError("ParentId", "Choose valid category");
                    return View();
                }

                Category category = new Category
                {
                    Name = model.Name,
                    Image = "sehv",
                    IsMain = model.IsMain,
                    Parent = parent
                };

                await _context.Categories.AddAsync(category);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
