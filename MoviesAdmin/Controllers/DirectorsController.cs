
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAdmin.Models;

public class DirectorsController : Controller
{
    private readonly MoviesAdminContext _context;

    public DirectorsController(MoviesAdminContext context)
    {
        _context = context;
    }

    // GET: DIRECTORS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Director.ToListAsync());
    }

    // GET: DIRECTORS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var director = await _context.Director
            .FirstOrDefaultAsync(m => m.ID == id);
        if (director == null)
        {
            return NotFound();
        }

        return View(director);
    }

    // GET: DIRECTORS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: DIRECTORS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Movies,Name")] Director director)
    {
        if (ModelState.IsValid)
        {
            _context.Add(director);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(director);
    }

    // GET: DIRECTORS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var director = await _context.Director.FindAsync(id);
        if (director == null)
        {
            return NotFound();
        }
        return View(director);
    }

    // POST: DIRECTORS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("ID,Movies,Name")] Director director)
    {
        if (id != director.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(director);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectorExists(director.ID))
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
        return View(director);
    }

    // GET: DIRECTORS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var director = await _context.Director
            .FirstOrDefaultAsync(m => m.ID == id);
        if (director == null)
        {
            return NotFound();
        }

        return View(director);
    }

    // POST: DIRECTORS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var director = await _context.Director.FindAsync(id);
        if (director != null)
        {
            _context.Director.Remove(director);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool DirectorExists(int? id)
    {
        return _context.Director.Any(e => e.ID == id);
    }
}
