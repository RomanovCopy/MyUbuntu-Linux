/*Добавить задачу для выполнения каждые 3 минуты (создание директории, запись в файл).*/

//директория для скриптов
sudo mkdir /home/romanov/myScripts
//разрешения для директории
sudo chmod 777 /home/romanov/myScripts
//создание файла скрипта
cat > /home/romanov/myScripts/myscript.sh
mkdir -p /home/romanov/myDates
date >> /home/romanov/myDates/dates.log
//разрешение на исполнение для файла скрипта
sudo chmod +x /home/romanov/myScripts/myscript.sh
//добавление задачи в cron
crontab -e
//добавляем запись
*/3 * * * * /home/romanov/myScripts/myscript.sh