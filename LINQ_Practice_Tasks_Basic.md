# Практические задачи по LINQ (Базовый уровень)

## Задача 1: Найти все четные числа и отсортировать их по возрастанию
```csharp
var numbers = new List<int> { 1, 5, 8, 12, 3, 9, 4, 7, 11, 2, 6, 10 };
// Ожидаемый результат: 2, 4, 6, 8, 10, 12
```

## Задача 2: Найти все слова длиннее 5 букв
```csharp
var words = new List<string> { 
    "apple", "banana", "orange", "grape", "kiwi", 
    "pear", "pineapple", "mango", "lemon" 
};
// Ожидаемый результат: "banana", "orange", "pineapple"
```

## Задача 3: Найти средний балл студентов
```csharp
public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

var students = new List<Student>
{
    new Student { Name = "Анна", Grade = 5 },
    new Student { Name = "Иван", Grade = 4 },
    new Student { Name = "Мария", Grade = 5 },
    new Student { Name = "Петр", Grade = 3 }
};
// Ожидаемый результат: 4.25
```

## Задача 4: Сгруппировать товары по категории и найти среднюю цену в каждой категории
```csharp
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

var products = new List<Product>
{
    new Product { Name = "Яблоко", Price = 50, Category = "Фрукты" },
    new Product { Name = "Молоко", Price = 80, Category = "Молочные" },
    new Product { Name = "Хлеб", Price = 30, Category = "Выпечка" },
    new Product { Name = "Банан", Price = 70, Category = "Фрукты" },
    new Product { Name = "Сыр", Price = 120, Category = "Молочные" }
};
// Ожидаемый результат: 
// Фрукты: 60
// Молочные: 100
// Выпечка: 30
```

## Задача 5: Найти сумму всех заказов для каждого клиента
```csharp
public class Order
{
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
}

var orders = new List<Order>
{
    new Order { CustomerName = "Иван", Amount = 1000 },
    new Order { CustomerName = "Мария", Amount = 1500 },
    new Order { CustomerName = "Иван", Amount = 800 },
    new Order { CustomerName = "Анна", Amount = 2000 },
    new Order { CustomerName = "Мария", Amount = 500 }
};
// Ожидаемый результат:
// Иван: 1800
// Мария: 2000
// Анна: 2000
```

## Задача 6: Найти книги с самым большим количеством страниц в каждом жанре
```csharp
public class Book
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Pages { get; set; }
}

var books = new List<Book>
{
    new Book { Title = "Книга 1", Genre = "Фантастика", Pages = 400 },
    new Book { Title = "Книга 2", Genre = "Детектив", Pages = 300 },
    new Book { Title = "Книга 3", Genre = "Фантастика", Pages = 350 },
    new Book { Title = "Книга 4", Genre = "Детектив", Pages = 450 }
};
// Ожидаемый результат:
// Фантастика: "Книга 1" (400 стр.)
// Детектив: "Книга 4" (450 стр.)
```

## Задача 7: Подсчитать количество оценок каждого балла
```csharp
var grades = new List<int> { 5, 4, 5, 3, 4, 5, 3, 4, 5, 2 };
// Ожидаемый результат:
// 5: 4 раза
// 4: 3 раза
// 3: 2 раза
// 2: 1 раз
```

## Задача 8: Найти города с населением больше 1 миллиона и отсортировать по убыванию населения
```csharp
public class City
{
    public string Name { get; set; }
    public int Population { get; set; }
}

var cities = new List<City>
{
    new City { Name = "Москва", Population = 12000000 },
    new City { Name = "Новосибирск", Population = 1500000 },
    new City { Name = "Краснодар", Population = 800000 },
    new City { Name = "Екатеринбург", Population = 1400000 },
    new City { Name = "Томск", Population = 500000 }
};
// Ожидаемый результат:
// Москва (12000000)
// Новосибирск (1500000)
// Екатеринбург (1400000)
```

## Задача 9: Найти среднюю зарплату по каждому отделу
```csharp
public class Employee
{
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

var employees = new List<Employee>
{
    new Employee { Department = "IT", Salary = 60000 },
    new Employee { Department = "HR", Salary = 45000 },
    new Employee { Department = "IT", Salary = 70000 },
    new Employee { Department = "HR", Salary = 40000 },
    new Employee { Department = "IT", Salary = 65000 }
};
// Ожидаемый результат:
// IT: 65000
// HR: 42500
```

## Задача 10: Найти фильмы с рейтингом выше 8, отсортированные по рейтингу
```csharp
public class Movie
{
    public string Title { get; set; }
    public double Rating { get; set; }
}

var movies = new List<Movie>
{
    new Movie { Title = "Фильм 1", Rating = 8.5 },
    new Movie { Title = "Фильм 2", Rating = 7.8 },
    new Movie { Title = "Фильм 3", Rating = 6.9 },
    new Movie { Title = "Фильм 4", Rating = 8.2 },
    new Movie { Title = "Фильм 5", Rating = 9.0 }
};
// Ожидаемый результат:
// Фильм 5 (9.0)
// Фильм 1 (8.5)
// Фильм 4 (8.2)
