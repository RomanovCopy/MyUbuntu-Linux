

# Проверяем ввод
if [ $# -eq 0 ]; then
    echo "Usage: $0 <directory>"
    exit 1
fi

# Проверяем существование директории
directory="$1"
if [ ! -d "$directory" ]; then
    echo "Error: Directory not found"
    exit 1
fi

# Удаление файлов с расширениями .bak, .tmp, .backup
find "$directory" -type f \( -name "*.bak" -o -name "*.tmp" -o -name "*.backup" \) -delete

echo "Cleanup complete in $directory"
