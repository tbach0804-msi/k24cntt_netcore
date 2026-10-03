
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThbLesson10EFDbFirst.Models;

public class ThbMembersController : Controller
{
    private readonly Thblesson10EfContext _context;

    public ThbMembersController(Thblesson10EfContext context)
    {
        _context = context;
    }

    // GET: THBMEMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.ThbMembers.ToListAsync());
    }

    // GET: THBMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var thbmember = await _context.ThbMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (thbmember == null)
        {
            return NotFound();
        }

        return View(thbmember);
    }

    // GET: THBMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: THBMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ThbUserName,ThbPassword,ThbFullName,ThbEmail,ThbPhone,ThbStatus")] ThbMember thbmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(thbmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(thbmember);
    }

    // GET: THBMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var thbmember = await _context.ThbMembers.FindAsync(id);
        if (thbmember == null)
        {
            return NotFound();
        }
        return View(thbmember);
    }

    // POST: THBMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,ThbUserName,ThbPassword,ThbFullName,ThbEmail,ThbPhone,ThbStatus")] ThbMember thbmember)
    {
        if (id != thbmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(thbmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThbMemberExists(thbmember.Id))
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
        return View(thbmember);
    }

    // GET: THBMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var thbmember = await _context.ThbMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (thbmember == null)
        {
            return NotFound();
        }

        return View(thbmember);
    }

    // POST: THBMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var thbmember = await _context.ThbMembers.FindAsync(id);
        if (thbmember != null)
        {
            _context.ThbMembers.Remove(thbmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ThbMemberExists(long? id)
    {
        return _context.ThbMembers.Any(e => e.Id == id);
    }
}
