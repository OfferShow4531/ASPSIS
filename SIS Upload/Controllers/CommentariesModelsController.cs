using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SIS_Upload.Data;
using SIS_Upload.Models;

namespace SIS_Upload.Controllers
{
    public class CommentariesModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CommentariesModelsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: CommentariesModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommentariesModel.ToListAsync());
        }
        public async Task<IActionResult> Comments()
        {
            return View(await _context.CommentariesModel.ToListAsync());
        }

        // GET: CommentariesModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentariesModel = await _context.CommentariesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentariesModel == null)
            {
                return NotFound();
            }

            return View(commentariesModel);
        }

        // GET: CommentariesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommentariesModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReleaseDate,Comment,NickName,Reputation")] CommentariesModel commentariesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commentariesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Comments));
            }
            return View(commentariesModel);
        }

        // GET: CommentariesModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentariesModel = await _context.CommentariesModel.FindAsync(id);
            if (commentariesModel == null)
            {
                return NotFound();
            }
            return View(commentariesModel);
        }

        // POST: CommentariesModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReleaseDate,Comment,NickName,Reputation")] CommentariesModel commentariesModel)
        {
            if (id != commentariesModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commentariesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentariesModelExists(commentariesModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(commentariesModel);
        }

        // GET: CommentariesModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commentariesModel = await _context.CommentariesModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commentariesModel == null)
            {
                return NotFound();
            }

            return View(commentariesModel);
        }

        // POST: CommentariesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commentariesModel = await _context.CommentariesModel.FindAsync(id);
            _context.CommentariesModel.Remove(commentariesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentariesModelExists(int id)
        {
            return _context.CommentariesModel.Any(e => e.Id == id);
        }
    }
}
