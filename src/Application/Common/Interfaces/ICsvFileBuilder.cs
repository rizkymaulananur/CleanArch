using CleanArch.Application.TodoLists.Queries.ExportTodos;

namespace CleanArch.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
