/* Создать файл file1 и наполнить его произвольным содержимым.
Скопировать его в file2.
Создать символическую ссылку file3 на file1.
Создать жёсткую ссылку file4 на file1.
Посмотреть, какие айноды у файлов.
Удалить file1.
Что стало с остальными созданными файлами?
Попробовать вывести их на экран.*/

cat > file1
cp file1 file2
ln -s file1 file3
ln file1 file4
ls -li
rm file1
ls -li
cat file3
cat file4

Символическая ссылка file3 стала нерабочей
Жесткая ссылка file4 не изменилась и по прежнему выводит содержимое file1