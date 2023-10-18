/*Дать созданным файлам другие, произвольные имена.
Создать новую символическую ссылку.
Переместить ссылки в другую директорию.*/

mv file2 file1  //символическая ссылка file3 снова стала рабочей
mv file4 file5
mkdir directory1
ln -s file3 file4
mv file3 directory1/file3
mv file4 directory1/file4
ls -li directory1/  //обе символических ссылки стали нерабочими
