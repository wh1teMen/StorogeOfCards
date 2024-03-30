# StorogeOfCards
# Текстовый процессор :page_with_curl:
*(Реализующий автодополнение слов по требованию пользователя)*



#### Скачать проект: [Проект.zip](https://disk.yandex.ru/d/a3pSASiWwwLbsA)
____

### Функции процессора:
+ Загрузка и анализ (входящего) текстового файла для формирования словаря «часто встречающихся слов».
+ Сопровождение словаря с помощью кнопок в верхнем меню программы.
+ Вывод подсказок (автодополнений) к словам в соответствии со сформированным словарём.
___
 ####  Используемые технологии: 
:heavy_check_mark: ***Visual Studio 2022*** </br>
:heavy_check_mark:   ***Windows Forms***</br>
:heavy_check_mark:   ***ООП***</br>
:heavy_check_mark:  ***ADO.net***</br>
:heavy_check_mark:   ***SQLite***</br>
:heavy_check_mark:   ***LINQ***

</br>

 ##  1.Создание словаря :hammer:

 #### Условия создания словаря:
   * Поле ввода не должно быть пустым
 #### Результат:
  * Формирование нового словаря по входящему файлу  

<img src="ReadmeContent/Create.gif" Alt="Create">

</br>

## <span style="font-size:22px;font-weight:bold;">2. Обновление словаря</span> :recycle:

#### Условия добавления в словарь:
  * Минимальное число символов, воспринимаемых приложением как слово – 3.
  * Минимальное число повторений слова в тексте для включения этого слова - 3. 
#### Результат:
   * Дополнение существующего словаря по входящему файлу.
 

<img src="ReadmeContent/Refresh.gif" Alt="Refresh">

</br>

## <span style="font-size:22px;font-weight:bold;">3. Очистка  словаря</span> :x:
 
 #### Результат:
   * Удаление всех данных словаря.
<img src="ReadmeContent/Delete.gif" Alt="Delete">


-----
<span style="color: #545463; height:30px; font-size:25px; font-family:COMIC SANS MS,Arial;font-weight:bold;">Выполнил: Белов Александр Сергеевич</span>

----
