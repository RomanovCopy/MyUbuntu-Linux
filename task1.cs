/*Используя команду cat, создать два файла с данными, а затем объединить их.
Просмотреть содержимое созданного файла.
Переименовать файл, дав ему новое имя.*/

 cat > file1.txt
 cat > file2.txt
 cat file1.txt >> file2.txt
 cat file2.txt
 mv file2.txt file3.txt
 