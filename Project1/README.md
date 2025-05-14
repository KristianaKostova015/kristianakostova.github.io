# 📊 Програма за статистика на числа

Този проект представлява конзолно приложение на C# (.NET), което позволява на потребителя да въвежда положителни цели числа и изчислява следните статистики:

- 🔢 Брой на въведените числа  
- ➕ Сума  
- 📈 Средно аритметично  
- ⬆️ Максимална стойност  
- ⬇️ Минимална стойност  

---

## 🚀 Стартиране на проекта

### 🧰 Изисквания

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (версия 6 или по-нова)
- Visual Studio / Visual Studio Code / терминал

### ▶️ Как да стартирате

1. Отворете терминал в папката с `.cs` файла.
2. Компилирайте и стартирайте.
   
## 🔄 Диаграма на потока (Mermaid)

mermaid
flowchart TD
    Start([Стартиране на програмата])
    ChooseOption{Нова или съществуваща дъска?}
    NewBoard[Създаване на нова дъска]
    LoadBoard[Зареждане от JSON]
    ShowBoard[Показване на Kanban дъската]
    KeyPress{Клавиш натиснат?}
    AddTask[[F2: Добавяне на задача]]
    MoveToProgress[[F5: Към In Progress]]
    MoveToDone[[F6: Към Done]]
    SaveExit[[F9: Запис и изход]]

    Start --> ChooseOption
    ChooseOption -->|Нова| NewBoard --> ShowBoard
    ChooseOption -->|Съществуваща| LoadBoard --> ShowBoard
    ShowBoard --> KeyPress
    KeyPress --> AddTask --> ShowBoard
    KeyPress --> MoveToProgress --> ShowBoard
    KeyPress --> MoveToDone --> ShowBoard
    KeyPress --> SaveExit


# 💻 Примерен изход
Въведи положителни цели числа. За край въведи 0.
Въведи число: 12
Въведи число: 8
Въведи число: 5
Въведи число: 0

📊 Резултати:
🔢 Въведени числа: 3
➕ Сума: 25
📈 Средно аритметично: 8.33
⬆️ Максимум: 12
⬇️ Минимум: 5

# 🛠 Технологии
Език: C#
Платформа: .NET
