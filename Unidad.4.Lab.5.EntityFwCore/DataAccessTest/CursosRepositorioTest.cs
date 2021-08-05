using System;
using System.Collections.Generic;
using Model;
using Xunit;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccessTest
{
    public class CursosRepositorioTest
    {
        [Fact]
        public void GetMateriasTest()
        {
            // Arrange
            var cursosRepositorio = new CursosRepositorio(new TestApplicationContextFactory());
            SeedTestDb(new TestApplicationContextFactory());
            //Act
            var result = cursosRepositorio.GetMaterias(5, 2008);
            //Assert
            Assert.Equal(expected: "Sistemas de Gestión", actual: result.FirstOrDefault().Descripcion);
            Assert.Equal(expected: 2008, actual: result.FirstOrDefault().Plan.Anio);
            Assert.Equal(expected: "Ingeniería en Sistemas de Información", actual: result.FirstOrDefault().Plan.Especialidad.Descripcion);
        }

        [Fact]
        public void InsertMateriaTest()
        {
            // Arrange
            var cursosRepositorio = new CursosRepositorio(new TestApplicationContextFactory());
            SeedTestDb(new TestApplicationContextFactory());
            var materia = new Materia()
            {
                Descripcion = "Mineria de Datos",
                HsSemanales = 4,
                HsTotales = 128
            };
            // Act
            cursosRepositorio.InsertMateria(materia, "Ingeniería en Sistemas");
            // Assert
            using (var context = new TestApplicationContextFactory().CreateContext())
            {
                var materiaInDb = context.Materias
                        .Include(m => m.Plan)
                        .ThenInclude(p => p.Especialidad)
                        .FirstOrDefault(m => m.Descripcion == materia.Descripcion);
                Assert.Equal(expected: 4, actual: materiaInDb.HsSemanales);
                Assert.Equal(expected: 128, actual: materiaInDb.HsTotales);
                Assert.Equal(expected: "Ingeniería en Sistemas de Información",
                             actual: materiaInDb.Plan.Especialidad.Descripcion);
            }
        }

        private void SeedTestDb(IApplicationContextFactory contextFactory)
        {
            var especialidades = new List<Especialidad>()
            {
                new()
                {
                    Descripcion = "Ingeniería en Sistemas de Información"
                },
                new()
                {
                    Descripcion = "Ingeniería Química"
                },
                new()
                {
                    Descripcion = "Ingeniería Eléctrica"
                },
                new()
                {
                    Descripcion = "Ingeniería Mecánica"
                },
                new()
                {
                    Id = 5,
                    Descripcion = "Ingeniería Civil"
                }
            };

            var planes = new List<Plan>()
            {
                new()
                {
                    Anio = 2008,
                    Especialidad = especialidades[0]
                },
                new()
                {
                    Anio = 1995,
                    Especialidad = especialidades[0]
                },
                new()
                {
                    Anio = 1994,
                    Especialidad = especialidades[3]
                },
                new()
                {
                    Anio = 2009,
                    Especialidad = especialidades[4]
                }
            };

            var materias = new List<Materia>
            {
                new()
                {
                    Descripcion = "Sistemas de Gestión",
                    HsSemanales = 4,
                    HsTotales = 136,
                    Plan = planes[0]
                },
                new()
                {
                    Descripcion = "Administración Gerencial",
                    HsSemanales = 6,
                    HsTotales = 102,
                    Plan = planes[0]
                }
            };
            using (ApplicationContext context = contextFactory.CreateContext())
            {
                context.Database.EnsureDeleted();
                context.Database.Migrate();

                context.Especialidades.AddRange(especialidades);
                context.Planes.AddRange(planes);
                context.Materias.AddRange(materias);
                context.SaveChanges();
            }
        }
    }
}
