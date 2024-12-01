using Command_pattern;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        ICommand insertHello = new InsertTextCommand(editor, "Hello");
        editor.ExecuteCommand(insertHello);

        ICommand insertWorld = new InsertTextCommand(editor, " World");
        editor.ExecuteCommand(insertWorld);

        ICommand deleteCommand = new DeleteTextCommand(editor, 6); // Удаляем " World"
        editor.ExecuteCommand(deleteCommand);

        // Отмена последней операции (удаление)
        editor.Undo();

        // Отмена последней операции (ввод текста " World")
        editor.Undo();

        // Отмена последней операции (ввод текста "Hello")
        editor.Undo();

        // Попытка отмены без команд
        editor.Undo();
    }
}