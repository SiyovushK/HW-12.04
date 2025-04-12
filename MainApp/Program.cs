using Domain.DTOs;

//LINQ Basic
//Task1
var numbers = new List<int> { 1, 5, 8, 12, 3, 9, 4, 7, 11, 2, 6, 10 };

var evens = numbers.Where(n => n%2 == 0).OrderBy(n => n).ToList();

var evens2 = (
    from n in numbers
    where n%2 == 0
    orderby n
    select n
).ToList();

foreach (var even in evens)
{
    System.Console.Write($"{even} ");
}

System.Console.WriteLine();
System.Console.WriteLine();

//Task2
var words = new List<string> { 
    "apple", "banana", "orange", "grape", "kiwi", 
    "pear", "pineapple", "mango", "lemon" 
};

var longWords = words.Where(w => w.Length > 5).ToList();

var longWords2 = (
    from w in words
    where w.Length > 5
    select w
).ToList();

foreach (var word in longWords)
{
    System.Console.Write($"{word} ");
}

System.Console.WriteLine();
System.Console.WriteLine();

//Task3
var students = new List<Student>
{
    new Student { Name = "Анна", Grade = 5 },
    new Student { Name = "Иван", Grade = 4 },
    new Student { Name = "Мария", Grade = 5 },
    new Student { Name = "Петр", Grade = 3 }
};

var AverageGrade = students
    .Average(s => s.Grade);

var AverageGrade2 = (
    from s in students
    select s.Grade
).Average();

System.Console.WriteLine(AverageGrade);

System.Console.WriteLine();

//Task4
var products = new List<Product>
{
    new Product { Name = "Яблоко", Price = 50, Category = "Фрукты" },
    new Product { Name = "Молоко", Price = 80, Category = "Молочные" },
    new Product { Name = "Хлеб", Price = 30, Category = "Выпечка" },
    new Product { Name = "Банан", Price = 70, Category = "Фрукты" },
    new Product { Name = "Сыр", Price = 120, Category = "Молочные" }
};

var GroupedAveragePricing = products
    .GroupBy(g => g.Category)
    .Select(g => new
    {
        Category = g.Key,
        AveragePrice = g.Average(p => p.Price)
    });

var GroupedAveragePricing2 = (
    from p in products
    group p by p.Category into g
    select new 
    {
        Category = g.Key,
        AveragePrice = g.Average(p => p.Price)
    }
);

foreach (var item in GroupedAveragePricing)
{
    System.Console.WriteLine($"{item.Category}: {item.AveragePrice}");
}

System.Console.WriteLine();

//Task5
var orders = new List<Order>
{
    new Order { CustomerName = "Иван", Amount = 1000 },
    new Order { CustomerName = "Мария", Amount = 1500 },
    new Order { CustomerName = "Иван", Amount = 800 },
    new Order { CustomerName = "Анна", Amount = 2000 },
    new Order { CustomerName = "Мария", Amount = 500 }
};

var SumOfOrders = orders
    .GroupBy(o => o.CustomerName)
    .Select(g => new 
    {
        Customer = g.Key,
        PriceOfOrders = g.Sum(c => c.Amount)
    });

var SumOfOrders2 = (
    from o in orders
    group o by o.CustomerName into g
    select new
    {
        Customer = g.Key,
        PriceOfOrders = g.Sum(c => c.Amount)
    }
);

foreach (var item in SumOfOrders)
{
    System.Console.WriteLine($"{item.Customer}: {item.PriceOfOrders}");
}

System.Console.WriteLine();

//Task6
var books = new List<Book>
{
    new Book { Title = "Книга 1", Genre = "Фантастика", Pages = 400 },
    new Book { Title = "Книга 2", Genre = "Детектив", Pages = 300 },
    new Book { Title = "Книга 3", Genre = "Фантастика", Pages = 350 },
    new Book { Title = "Книга 4", Genre = "Детектив", Pages = 450 }
};

var Pages = books
    .GroupBy(b => b.Genre)
    .Select(b => new
    {
        Genre = b.Key,
        MaxPages = b.Max(b => b.Pages)
    });

var Pages2 = (
    from b in books
    group b by b.Genre into g
    select new
    {
        Genre = g.Key,
        MaxPages = g.Max(b => b.Pages)
    }
);

foreach (var page in Pages)
{
    System.Console.WriteLine($"{page.Genre}: '{page.MaxPages}'");
}

System.Console.WriteLine();

//Task7
var grades = new List<int> { 5, 4, 5, 3, 4, 5, 3, 4, 5, 2 };

var Counting = grades
    .GroupBy(g => g)
    .Select(g => new
    {
        Grade = g.Key,
        TheCount = g.Count()
    });

var Counting2 = (
    from g in grades
    group g by g into gr
    select new 
    {
        Grade = gr.Key,
        TheCOunt = gr.Count()
    }
);

foreach (var grade in Counting)
{
    System.Console.WriteLine($"{grade.Grade}: {grade.TheCount} times");
}

System.Console.WriteLine();

//Task8
var cities = new List<City>
{
    new City { Name = "Москва", Population = 12000000 },
    new City { Name = "Новосибирск", Population = 1500000 },
    new City { Name = "Краснодар", Population = 800000 },
    new City { Name = "Екатеринбург", Population = 1400000 },
    new City { Name = "Томск", Population = 500000 }
};

var Cities = cities
    .Where(c => c.Population > 1000000)
    .OrderByDescending(c => c.Population)
    .ToList();

var Cities2 = (
    from c in cities
    where c.Population > 1000000
    orderby c.Population
    select c
).ToList();

foreach (var city in Cities)
{
    System.Console.WriteLine($"{city.Name} ({city.Population})");
}

System.Console.WriteLine();

//Task9
var employees = new List<Employee>
{
    new Employee { Department = "IT", Salary = 60000 },
    new Employee { Department = "HR", Salary = 45000 },
    new Employee { Department = "IT", Salary = 70000 },
    new Employee { Department = "HR", Salary = 40000 },
    new Employee { Department = "IT", Salary = 65000 }
};

var SalaryAverage = employees
    .GroupBy(e => e.Department)
    .Select(e => new
    {
        Department = e.Key,
        Salary = e.Average(e => e.Salary)
    });

var SalaryAverage2 = (
    from e in employees
    group e by e.Department into g
    select new 
    {
        Department = g.Key,
        Salary = g.Average(e => e.Salary)
    }
);

foreach (var item in SalaryAverage)
{
    System.Console.WriteLine($"{item.Department}: {item.Salary}");
}

System.Console.WriteLine();

//Task10
var movies = new List<Movie>
{
    new Movie { Title = "Фильм 1", Rating = 8.5 },
    new Movie { Title = "Фильм 2", Rating = 7.8 },
    new Movie { Title = "Фильм 3", Rating = 6.9 },
    new Movie { Title = "Фильм 4", Rating = 8.2 },
    new Movie { Title = "Фильм 5", Rating = 9.0 }
};

var Movies = movies
    .Where(m => m.Rating > 8)
    .OrderByDescending(m => m.Rating)
    .ToList();

var Movies2 = (
    from m in movies
    where m.Rating > 8
    orderby m.Rating descending
    select m
).ToList();

foreach (var movie in Movies)
{
    System.Console.WriteLine($"{movie.Title} ({movie.Rating})");
}


//LINQ Medium
//Task1
