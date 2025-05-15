flowchart TD
    NamingConventions[Конвенции за именуване]
    
    NamingConventions --> Classes["Класове\nUserService\nPascalCase"]
    NamingConventions --> Methods["Методи\nGetUserById()\nPascalCase"]
    NamingConventions --> Variables["Променливи\nuserName\ncamelCase"]
    NamingConventions --> Constants["Константи\nMAX_RETRIES\nUPPER_SNAKE"]
    NamingConventions --> Interfaces["Интерфейси\nIUserRepository\nPascalCase + I"]
    NamingConventions --> Enums["Enum-и\nUserType.Admin\nPascalCase"]

    NamingConventions --> Avoid["❌ Избягвай"]
    Avoid --> BadNames1["data1, temp, x"]
    Avoid --> BadNames2["cpd, nxr"]

    NamingConventions --> Tip["🧠 Съвет"]
    Tip --> Meaningful["Използвай значещи имена"]
