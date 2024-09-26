    List<string> TaskList = [];

    int menuSelected = 0;
    do
    {
        menuSelected = ShowMainMenu();

        switch(menuSelected)
        {
            case TipoMenu.ADD: ShowMenuAdd(); break;
            case TipoMenu.REMOVE: RemoveTask(); break;
            case TipoMenu.LIST: ShowPendingTask(); break;
            default: Console.WriteLine("MENU NO DISPONIBLE."); break;
        };

    } while (menuSelected != TipoMenu.EXIST);
        
    
    sbyte ShowMainMenu()
    {
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Ingrese la opción a realizar: ");
        Console.WriteLine("1. Nueva tarea");
        Console.WriteLine("2. Remover tarea");
        Console.WriteLine("3. Tareas pendientes");
        Console.WriteLine("4. Salir");

        string inputValue = Console.ReadLine();

        if(ValideInputValue(inputValue))
        {
            return Convert.ToSByte(inputValue);
        }

        return 0;
    }

    bool ValideInputValue(string value)
    {
        var valueIsValid = sbyte.TryParse(value, out var result);

        return valueIsValid && TipoMenu.All.Contains(result);
    }

    void RemoveTask()
    {
        try
        {
            Console.WriteLine("Ingrese el número de la tarea a remover: ");

            ShowListTask();

            string inputValue = Console.ReadLine();

            var valueIsValid = sbyte.TryParse(inputValue, out var numberTaskToRemove);

            var totalTask = TaskList.Count;
            if(!valueIsValid || (numberTaskToRemove > totalTask || numberTaskToRemove <= 0 ))
            {
                Console.WriteLine("Esa tarea no existe. ");
                return;
            }

            int indexToRemove = numberTaskToRemove - 1;
            
            if (indexToRemove > -1 && totalTask > 0)
            {
                string taskToRemove = TaskList[indexToRemove];
                TaskList.RemoveAt(indexToRemove);
                Console.WriteLine($"Tarea {taskToRemove} eliminada");   
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ha ocurrido un error al eliminar la tarea. ");   
        }
    }

    void ShowMenuAdd()
    {
        Console.WriteLine("Ingrese el nombre de la tarea: ");
        string taskName = Console.ReadLine();
        TaskList.Add(taskName);
        Console.WriteLine("Tarea registrada");
    }

    void ShowPendingTask()
    {
        if (TaskList?.Count > 0)
        {
            Console.WriteLine("----------------------------------------");
            ShowListTask();
        } 
        else
            Console.WriteLine("No hay tareas por realizar");
    }

    void ShowListTask()
    {
        var taskIndex = 0;
        TaskList.ForEach(task=> Console.WriteLine($"{++taskIndex} . {task}"));
        Console.WriteLine("----------------------------------------");
    }

