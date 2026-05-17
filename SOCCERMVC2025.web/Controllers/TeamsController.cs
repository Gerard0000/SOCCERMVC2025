using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOCCERMVC2025.web.Data;
using SOCCERMVC2025.web.Data.Entities;

namespace SOCCERMVC2025.web.Controllers;

public class TeamsController : Controller
{
    private readonly DataContext _context;

    public TeamsController(DataContext context)
    {
        _context = context;
    }

    // GET: Teams
    public async Task<IActionResult> Index()
    {
        return _context.Teams != null ?
                    View(await _context.Teams.ToListAsync()) :
                    Problem("Entity set 'DataContext.Teams'  is null.");
    }

    // GET: Teams/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }

        var teamEntity = await _context.Teams
            .FirstOrDefaultAsync(m => m.Id == id);
        if (teamEntity == null)
        {
            return NotFound();
        }

        return View(teamEntity);
    }

    // GET: Teams/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Teams/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(TeamEntity teamEntity)
    {
        if (ModelState.IsValid)
        {
            _context.Add(teamEntity);
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.Contains("duplicate"))
                {
                    ModelState.AddModelError(string.Empty, $"Already exist a team: {teamEntity.Name}");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
        }
        return View(teamEntity);
    }

    // GET: Teams/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }

        var teamEntity = await _context.Teams.FindAsync(id);
        if (teamEntity == null)
        {
            return NotFound();
        }
        return View(teamEntity);
    }

    // POST: Teams/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, TeamEntity teamEntity)
    {
        if (id != teamEntity.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Update(teamEntity);
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.Contains("duplicate"))
                {
                    ModelState.AddModelError(string.Empty, $"Already exist a team: {teamEntity.Name}");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                }
            }
        }
        return View(teamEntity);
    }

    // GET: Teams/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null || _context.Teams == null)
        {
            return NotFound();
        }

        var teamEntity = await _context.Teams
            .FirstOrDefaultAsync(m => m.Id == id);
        if (teamEntity == null)
        {
            return NotFound();
        }

        _context.Teams.Remove(teamEntity);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TeamEntityExists(int id)
    {
        return (_context.Teams?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}