using Pride;

namespace PrideCli
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse porta, tellus a accumsan elementum, purus justo imperdiet arcu, et faucibus quam urna vitae quam. Nullam quam nisi, condimentum in rutrum nec, tristique ac ligula. Donec eget malesuada sapien. Maecenas ornare egestas suscipit. In vel eros sed massa efficitur congue nec eget massa. Donec pretium ipsum tempus quam porttitor, nec placerat tortor blandit. Duis lacinia vitae nunc at molestie. Maecenas rhoncus justo nec scelerisque egestas. Phasellus venenatis tortor et urna placerat tincidunt. Integer commodo, odio non suscipit facilisis, enim eros varius arcu, quis feugiat dolor mi vitae elit. Mauris non egestas arcu. In accumsan dolor in mauris viverra tincidunt. Sed bibendum enim quis justo lacinia, quis maximus turpis tempus.";
            PrideConsole.WriteWords(text);
        }
    }
}
