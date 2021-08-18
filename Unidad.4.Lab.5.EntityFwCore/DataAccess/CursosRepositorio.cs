using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    public class CursosRepositorio
    {
        private readonly IApplicationContextFactory _contextFactory;
        public CursosRepositorio(IApplicationContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        /// Traer las materias con menos de x horas semanales con el plan z ordenados 
        /// en forma descendente por HsSemanales, incluyendo los datos del plan y la 
        /// especialidad asociados a esta
        public IEnumerable<Materia> GetMaterias(int hsSemanales, int anioPlan)
        {
            List<Materia> materias = new List<Materia>();
            using (var context = _contextFactory.CreateContext())
            {
                materias = context.Materias
                    .Where(m => m.HsSemanales < hsSemanales && m.Plan.Anio == anioPlan)
                    .OrderByDescending(m => m.HsSemanales)
                    .Include(m => m.Plan)
                    .ThenInclude(p => p.Especialidad)
                    .ToList<Materia>();
            }
            return materias;
        }

        /// Guardar una materia con el plan mas actual que este asociado con la especialidad
        /// que contenga el nombre parcial enviado como parametro
        public void InsertMateria(Materia materia, string nombreParcialEspecialidad)
        {
            using (var context = _contextFactory.CreateContext())
            {
                try
                {
                    Plan plan = context.Planes
                        .Where(p => p.Especialidad.Descripcion.Contains(nombreParcialEspecialidad))
                        .OrderByDescending(p => p.Anio)
                        .ToList<Plan>()[0];
                    materia.Plan = plan;
                    materia.PlanId = plan.Id;
                    context.Materias.Add(materia);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al recuperar el plan {e.Message}");
                }
            }
        }
    }
}
