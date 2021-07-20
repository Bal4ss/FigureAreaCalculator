# FigureAreaCalculator - библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

- Никитин Никита Евгеньевич 
- wwwnikita18@gmail.com
- тел: +7(961) 758-34-84

# Оглавление 
[1. Постановка задачи](#task)  
[2. Ответы](#realization)  
[3. Инструменты используемые в ходе работы](#tools)  

<a name="task"><h1>Постановка задачи</h1></a>
### Содержание
[1. Вопрос 1](#q1)
[2. Вопрос 2](#q2)
[3. Вопрос 3](#q3)

<a name="q1"><h3>Вопрос 1</h3></a>
Был ли у вас опыт веб-разработки?
> Приложите ссылку на репозиторий с вашим веб-проектом, если возможно.

<a name="q2"><h3>Вопрос 2</h3></a>
```
Выполните практическое задание ниже.
Задание: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
```
> Дополнительно к работоспособности оценим:
1. Юнит-тесты;
2. Легкость добавления других фигур;
3. Вычисление площади фигуры без знания типа фигуры;
4. Проверку на то, является ли треугольник прямоугольным.

<a name="q3"><h3>Вопрос 3</h3></a>
> В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

<a name="realization"><h1>Ответы</h1></a>  
### Содержание
[1. Ответ 1](#a1)
[2. Ответ 2](#a2)
[3. Ответ 3](#a3)

<a name="a1"><h3>Ответ 1</h3></a>
```
~2 года фриланса (cсылки на работы не сохранились)
```
Занимался (веб):
1. создание сайтов; 
2. написание модулей к сайтам; 
3. создание телеграм/дискорд ботов.

<a name="a2"><h3>Ответ 2</h3></a>
> Реализация представлена в текущем репозиторий

<a name="a3"><h3>Ответ 3</h3></a>
```
SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON Category.Id = ProductCategory.CategoryId
```

<a name="tools"><h1>Инструменты используемые в ходе работы</h1></a>  
- JetBrains Rider
- C#  
