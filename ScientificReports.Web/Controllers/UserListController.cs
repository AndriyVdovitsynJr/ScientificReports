//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using ScientificReports.BLL.Models;
//using ScientificReports.BLL.Services;
//using ScientificReports.DAL.Models;
//using ScientificReports.Web.ViewModels;

//namespace ScientificReports.Web.Controllers
//{
//    public class UserListController : Controller
//    {
//        private readonly IMapper _mapper;
//        private IBaseCrudService<Faculty> _service;

//        public UserListController(IBaseCrudService<User> service, IMapper mapper)
//        {
//            _mapper = mapper;
//            _service = service;
//        }

//        [HttpGet]
//        public async Task<IActionResult> Index()
//        {
//            var model = await _service.GetAll(); // Rename -async
//            var viewmodel = _mapper.Map<List<UserListViewModel>>(model);
//            return View(viewmodel);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(UserListViewModel viewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                var model = _mapper.Map<User>(viewModel);
//                _service.Add(model);
//                _service.Save();
//                return RedirectToAction("Index");
//            }

//            return View(viewModel);
//        }

//        [HttpGet]
//        public IActionResult Edit(int id)
//        {
//            var model = _service.GetById(id);
//            var viewModel = _mapper.Map<UserListViewModel>(model);
//            return View(viewModel);
//        }

//        [HttpPost]
//        public ActionResult Edit(UserListViewModel viewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                var model = _mapper.Map<UserList>(viewModel);

//                _service.Update(model);
//                _service.Save();
//                return RedirectToAction("Index");
//            }

//            return View(viewModel);
//        }

//        [HttpGet]
//        public ActionResult Delete(int id)
//        {
//            var model = _service.GetById(id);
//            var viewModel = _mapper.Map<UserListViewModel>(model);
//            return View(viewModel);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, UserList model)
//        {
//            _service.Delete(id);
//            _service.Save();
//            return RedirectToAction("Index");
//        }

//        [HttpGet]
//        public IActionResult Details(int id)
//        {
//            var model = _service.GetById(id);
//            var dataViewModel = _mapper.Map<UserListViewModel>(model);
//            return View(dataViewModel);
//        }
//    }
//}
