Теория:
1. Доступное объяснение структур данных и алгоритмов можете найти в книге "Грокаем алгоритмы" (~до 54, тут заканчивается описание связного листа), которую я добавил в литературу. Она читается относительно легко. После связного листа рассмотрите также Хеш таблицу(~101 стр)
2. Задачи реального мира, в которых используется стек (абзац Applications): https://levelup.gitconnected.com/the-stack-data-structure-what-is-it-and-how-is-it-used-in-javascript-23562fb8a590
3. Пример использования стека в алгоритме поиска в глубину: http://www.cs.toronto.edu/~heap/270F02/node36.html
4. Задачи реального мира, в которых используется очередь (Practical Applications): https://medium.com/@adarsh_menon_/queue-data-structure-practical-applications-operations-43efec72a58d
5. Описание локальных методов, которые мы упоминали на уроке: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions

Практика:
1. Для того чтоб набивать руку (и не забыть как выглядят классы коллекций) создайте по экземпляру каждой из рассмотренной нами коллекции. Заполните их исполльзуя методы добавления, доступные в каждой коллекции. Попробуйте пройтись по колллекциям разными операторами цикла(обязательно попробуйте простой for и посмотрите как происходит индексирование в каждой коллекции).
2. Создайте Dictionary<IKey, IValue>, в котором IKey и IValue - созданные вами интерфейсы. Создайте таке минимум по 2 класса, которые реализуют каждый интерфейс. Заполните Dictionary<IKey, IValue> экземплярами созданных вами классов (В одной коллекции попробуйте использовать обе реазлизации каждого из интерфейсов). Выведите пары ключ и значения из созданной вами коллекции в консоль.
3. Создайте LinkedList<T> заполните его 10 или больше элементами и попробуйте удалить элемент который находится в середине коллекции. 