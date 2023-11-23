
# Проверяем ввод
if [ $# -eq 0 ]; then
    echo "Usage: $0 <directory>"
    exit 1
fi

# Проверяем существование директории
src_directory="$1"
if [ ! -d "$src_directory" ]; then
    echo "Error: Source directory not found"
    exit 1
fi

# Создаем директории для владельцев файлов
find "$src_directory" -type f -exec sh -c 'mkdir -p "$0/${1%/*}"' "$src_directory" {} \;

# Копируем файлы в соответствующие директории
find "$src_directory" -type f -exec sh -c 'cp "$0" "$1/${2%/*}"' "$src_directory" {} {} \;

echo "Sorting complete in $src_directory"
