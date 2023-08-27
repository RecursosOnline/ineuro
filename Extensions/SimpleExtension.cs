using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ineuro.Extensions;

public static class SimpleExtension
{
    private static IContainer Cell(this IContainer container, bool dark)
    {
        return container
            .Border(0)
            .Background(dark ? Colors.Grey.Lighten2 : Colors.White)
            .Padding(10);
    }

    // displays only text label
    public static void LabelCell(this IContainer container, string text) => container.Cell(true).Text(text).Bold();

    // allows you to inject any type of content, e.g. image
    public static IContainer ValueCell(this IContainer container, string text)
    {
        container.Cell(false).Text(text);
        return container;
    }
}