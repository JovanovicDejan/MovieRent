using MovieRentProj.Models;
using MovieRentProj.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MovieRentProj.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MemberShipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", viewModel);
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.DateOfBirth = customer.DateOfBirth;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null) { return HttpNotFound(); }
            return View(customer);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MemberShipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}