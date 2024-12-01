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

        ICommand deleteCommand = new DeleteTextCommand(editor, 6); // Удаление " World"
        editor.ExecuteCommand(deleteCommand);

        // Отмена последней операции
        editor.Undo();

        // Отмена последней операции
        editor.Undo();

        // Отмена последней операци
        editor.Undo();

        // Попытка отмены без команд
        editor.Undo();
    }
}
