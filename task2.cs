/*Создать несколько файлов.
Создать директорию, переместить файл туда.
Удалить все созданные в этом и предыдущем задании директории и файлы.*/

touch file4.txt
touch file5.txt
mkdir directory1
mv file4.txt directory1/file4.txt
mv file5.txt directory1/file5.txt
rm -r directory1/
rm file1.txt file3.txt
