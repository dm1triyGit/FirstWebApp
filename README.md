# My orders

Инструкция по запуску приложения:
Приложение можно запустить при наличии sql server, открыв файл MyOrders.sln в Visual Studio.
1. Необходимо открыть консоль менджера пакетов и сделать миграцию в базу данных вашего сервера. (написать в консоль add-migration Initial)
![screenshot of sample](Scr1.jpg)
2. Далее следует обновить базу данных. (написать в консоль update-database)
![screenshot of sample](Scr2.jpg)
3. Запустить приложение из проекта в Visual Studio.
