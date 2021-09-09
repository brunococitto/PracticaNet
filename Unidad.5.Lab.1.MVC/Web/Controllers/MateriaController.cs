using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System;

namespace Web.Controllers
{
    public class MateriaController : Controller
    {
        private readonly ILogger<MateriaController> _logger;
        private readonly IMateriaRepository _materiaRepository;
        private readonly IPlanRepository _planRepository;

        public MateriaController(ILogger<MateriaController> logger, IMateriaRepository materiaRepository, IPlanRepository planRepository)
        {
            _logger = logger;
            _logger.LogDebug("Inicializado controlador MateriaController");
            _materiaRepository = materiaRepository;
            _planRepository = planRepository;
        }
        public IActionResult Index() => RedirectToAction("List");
        public IActionResult List() => View(_materiaRepository.GetAll());

        [HttpGet] // Es opcional declarar esta anotacion
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Materia? materia = _materiaRepository.GetOne((int)id);
            if (materia == null) return NotFound();
            return View(new EditMateriaViewModel(materia, _planRepository.GetAll()));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Descripcion, HsSemanales, HsTotales, PlanId")]Materia materia)
        {
            if (id != materia.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _materiaRepository.Update(materia);
                return RedirectToAction("List");
            }
            return View(new EditMateriaViewModel(materia, _planRepository.GetAll()));
        }

        [HttpGet]
        public IActionResult Create() => View(new CreateMateriaViewModel(null, _planRepository.GetAll()));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id, Descripcion, HsSemanales, HsTotales, PlanId")] Materia materia)
        {
            if (ModelState.IsValid)
            {
                _materiaRepository.Add(materia);
                return RedirectToAction("List");
            }
            return View(new CreateMateriaViewModel(materia, _planRepository.GetAll()));
        }
    }
}