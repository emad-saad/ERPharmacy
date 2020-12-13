using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sehetak.Models;

namespace sehetak.Controllers
{
    public class ItemsController : Controller
    {
        private readonly SOFTECHDB9Context _context;

        public ItemsController(SOFTECHDB9Context context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await _context.Items.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .FirstOrDefaultAsync(m => m.Itemcode == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }


        [HttpPost]
        public async Task<IActionResult> Search(string code, string searchString, Items items)
        {
            //Lambda Linq to entity does not support Int32
            //var search = (from d in db.students where d.No == Convert.ToInt32(id) && d.Name == id select d).ToList();
            //var search = db.students.Where(d => d.No == Convert.ToInt32(id) && d.Name == id).ToList();
            var query = await _context.Items
                .FirstOrDefaultAsync(m => m.Itemcode == code);
            var item = await _context.Itemsproducers.FirstOrDefaultAsync(i => i.Itemproducercode == query.Itemproducercode);
            var itemorig = await _context.Itemsorigin.FirstOrDefaultAsync(o => o.Itemorigincode == query.Itemorigincode);
            var itemsunits = await _context.Itemsunits.FirstOrDefaultAsync(u => u.Unitcode == query.Unitcode);
            var itemsclassif = await _context.Itemsclassif.FirstOrDefaultAsync(c => c.Itemsclassifcode == query.Itemclassifcode);

            //if (!string.IsNullOrEmpty(code))
            //{
            //    query = query.Where(d => d.Itemcode == code);
            //}
            //if (!string.IsNullOrEmpty(searchString))
            //    query = query.Where(d => d.Itemname.Contains(searchString));

            //var search = query.ToList();

            //item = item.Where(i => i.Itemproducercode == search.Itemproducercode);
            //itemorig = itemorig.Where(o => o.Itemorigincode == search.Itemorigincode);
            //itemsunits = itemsunits.Where(u => u.Unitcode == search.Unitcode);
            //itemsclassif = itemsclassif.Where(c => c.Itemsclassifcode == search.Itemclassifcode);
            if (item.Itemproducername == null) ViewBag.item = " ";
            else
                ViewBag.items = item.Itemproducername;
            if (itemorig == null) ViewBag.itemsorig = " ";
            else
                ViewBag.itemorig = itemorig.Itemoriginname;
            if (itemsunits.Unitname == null) ViewBag.itemsorig = " ";
            else

                ViewBag.itemsunits = itemsunits.Unitname;
            if (itemsclassif.Itemsclassifname == null) ViewBag.itemsclassif = " ";
            else ViewBag.itemsclassif = itemsclassif.Itemsclassifname;

            return View("ItemCard", query);
        }



        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ItemCard()
        {
            var items = _context.Items.First();

            return View(items);
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Familycode,Itemcode,Itemname,Unitcode,Itemcostprice,Itemsaleprice,ItemcodeAlt1,ItemcodeAlt2,ItemcodeAlt3,Itemclassifcode,Itemsalestax,ItemsalepriceTax,Itembarcode,Pharmacydiscp,Additionaldiscp,Specialdiscp,Itemshapecode,Itemorigincode,Itemeffectcode,Suppcode,ItemnameScientific,Itemexpiry,Itemcomment,ItemsalepriceExtrap,Usercode,Itemnomoreuse,PrintBarcode,HiTypecode,Fmi,Itemsaleprice2,Itemslevel,Itemproducercode,Suppitemcode,Itemsort,Itemmodified,Packqty,Unitsaleprice,Fridgeitem,Hasdifforigin,Hasdiffpacks,Itemtrans,Itemsalestaxp,Itemmedicine,Itemstoreclassif,ItemupdtMonthlyqty,Itemlastupdate,Itemtrans1,Itemtrans2,Itemtrans3,Itemsearchkey,Itemarchive,Itemeffectcode2,Itempartno,Itemnosaleclassif,Itemonweb,Itemrefcode,Itemperformrate,Itempointsys,Itemexpcode,Costcentercode,Itemmanuf,Itemglobalcode,Testcode,Posdiscp")] Items items)
        {
            if (ModelState.IsValid)
            {
                _context.Add(items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(items);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            return View(items);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Familycode,Itemcode,Itemname,Unitcode,Itemcostprice,Itemsaleprice,ItemcodeAlt1,ItemcodeAlt2,ItemcodeAlt3,Itemclassifcode,Itemsalestax,ItemsalepriceTax,Itembarcode,Pharmacydiscp,Additionaldiscp,Specialdiscp,Itemshapecode,Itemorigincode,Itemeffectcode,Suppcode,ItemnameScientific,Itemexpiry,Itemcomment,ItemsalepriceExtrap,Usercode,Itemnomoreuse,PrintBarcode,HiTypecode,Fmi,Itemsaleprice2,Itemslevel,Itemproducercode,Suppitemcode,Itemsort,Itemmodified,Packqty,Unitsaleprice,Fridgeitem,Hasdifforigin,Hasdiffpacks,Itemtrans,Itemsalestaxp,Itemmedicine,Itemstoreclassif,ItemupdtMonthlyqty,Itemlastupdate,Itemtrans1,Itemtrans2,Itemtrans3,Itemsearchkey,Itemarchive,Itemeffectcode2,Itempartno,Itemnosaleclassif,Itemonweb,Itemrefcode,Itemperformrate,Itempointsys,Itemexpcode,Costcentercode,Itemmanuf,Itemglobalcode,Testcode,Posdiscp")] Items items)
        {
            if (id != items.Itemcode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(items);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsExists(items.Itemcode))
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
            return View(items);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .FirstOrDefaultAsync(m => m.Itemcode == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var items = await _context.Items.FindAsync(id);
            _context.Items.Remove(items);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsExists(string id)
        {
            return _context.Items.Any(e => e.Itemcode == id);
        }
    }
}
