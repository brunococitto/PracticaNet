# Unidad 4 - Laboratorio 5

### Objetivos
Interiorizarse con conceptos de Entity Framework Core como lo son el contexto, los consultas y carga temprana de entidades.

### Pasos
1. Instalar el paquete para entity fw core correspondiente al provider Sqlite ejecutando en la terminal sobre el directorio del proyecto ***DataAccess*** (recomendación: usar el comando current-directory/cd para moverse a el):
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```

2. En la clase ```ApplicationContext```:
 crear las propiedades ```DbSet<T>``` (las cuales representan tablas en la db) para cada entidad del dominio (Materia, Planes y Especialidades)>. Luego crear un constructor que tome ```DbContextOptions<ApplicationContext>``` como parámetro y lo envié al constructor de la clase padre ```DbContext```
<details close>
<summary>Ver Código</summary>

```c#
public DbSet<Especialidad> Especialidades { get; set; }
public DbSet<Plan> Planes { get; set; }
public DbSet<Materia> Materias { get; set; }
public ApplicationContext(DbContextOptions<ApplicationContext> contextOptions): base(contextOptions) { }
```

</details>

3. Instalar el paquete ***Microsoft.EntityFrameworkCore.Design*** . Este es común a todos los providers y sirve para tareas que se ejecutan en tiempo de diseño, como las migraciones. Al igual que con el anterior paquete moverse al directorio del proyecto ***DataAccess*** y ejecutar:
```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```

4. En la clase ```ApplicationContextDesignTimeFactory``` método de la interfaz ```IDesignTimeDbContextFactory```: construir un instancia de  ```DbContextOptionsBuilder<ApplicationContext>``` para luego usar uno de sus metodos que indica que se va a usar sqlite (```UseSqlite()```, para las migraciones solo es necesario saber que db se va a utilizar,  por lo que no es necesaria el uso de la connection string), retornar una nueva instancia de ```ApplicationContext``` enviando esta el optionsBuilder como parametro.
<details close>
<summary>Ver Código</summary>

```c#
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
optionsBuilder.UseSqlite();

return new ApplicationContext(optionsBuilder.Options);
```

</details> 

5. Si no se lo ha hecho previamente en la terminal  instalar entity framework core tools globalmente
```bash
dotnet tool install --global dotnet-ef
```

6. Aprovechando lo anterior ir a la terminal en el directorio correspondiente al proyecto ***DataAccess*** y ejecutar 
```bash
dotnet ef migrations add Inicial
```

7. En la clase ```DataAccess``` agregar el campo ```_contextFactory``` de tipo ```IApplicationContextFactory```, inicializarlo en el constructor
<details close>
<summary>Ver Código</summary>

```c#
private readonly IApplicationContextFactory _contextFactory;

public CursosRepositorio(IApplicationContextFactory contextFactory)
{
    _contextFactory = contextFactory;
}
```

</details>

</br>

8. Completar la implementación en la función correspondiente de la clase ```DataAccess```, por ejemplo:
``` c#
public class CursosRepositorio
{
    public IEnumerable<Materia> GetMaterias(int hsSemanales, int anioPlan) {...}
}
```

9. En la clase ***DataAccessTest*** ir a ***Prueba***/***Ejecutar todas las pruebas*** de la barra de herramientas de VS. Esto es para verificar que la implementación cumpla con las especificaciones requeridas. Por ejemplo en el caso anterior seria:
``` c#
public class CursosRepositorioTest
{
    [Fact]
    public void GetMateriasTest() {...}
}
```

### Ejercicios
> Recordar desechar la instancia de context una vez realizada la consulta mediante un bloque ```using``` que cree una instancia del context mediante ```_contextFactory```
1. Traer las materias con menos de **x** horas semanales con el plan del año **z**, ordenados en forma descendente por horas semanales, incluyendo los datos del plan y la especialidad asociados a estas
<details close>
<summary>Ver Pista</summary>

```c#
using (ApplicationContext context = _contextFactory.CreateContext()) {...}
```
Usar ```.Include()``` y ```.ThenInclude()```

</details>
<details close>
<summary>Ver Código</summary>

```c#
using (ApplicationContext context = _contextFactory.CreateContext())
{
    return context.Materias
        .Include(m => m.Plan).ThenInclude(p => p.Especialidad)
        .Where(m => m.HsSemanales <= hsSemanales && m.Plan.Anio == anioPlan)
        .OrderByDescending(m => m.HsSemanales).ToList();
}
```

</details>

</br>

2. Guardar una materia con el plan mas actual que este asociado a la especialidad con el nombre parcial enviado como parámetro.
<details close>
<summary>Ver Pista</summary>

En la primera consulta para obtener el plan mas actual asociado a la especialidad con el nombre parcial primero filtrar por especialidad, luego ordenar por año y finalmente obtener el primero

Usar la función ```.Contains()``` de la clase ```String```

</details>
<details close>
<summary>Ver Codigo</summary>

```c#
using (ApplicationContext context = _contextFactory.CreateContext())
{
    var plan = context.Planes
        .Where(p => p.Especialidad.Descripcion.Contains(nombreParcialEspecialidad))
        .OrderBy(p => p.Anio)
        .FirstOrDefault();
        
    materia.Plan = plan;
    context.Materias.Add(materia);
    context.SaveChanges();
}
```

</details>