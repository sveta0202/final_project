# final_project

## Цель проекта: 
### Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
### Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Алгоритм решения:
## Начальные данные, необходимые для функции:
### Два массива: изначальный и финальный такой же длины. 
## 1 функция (FillingTheFinalArray)
### Функция идёт циклом по массиву и проверяет длину каждого элемента. Если элемент меньше 3 символов или равен 3, этот элемент массива заносится в count элемент финального массива. Переменная count чтобы поочередно закидывать из первого массива во второй и чтобы при выводе не было пробелов между элементами. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца изначального массива.

### Вторая функция выводит в консоль финальный массив с пробелами.
