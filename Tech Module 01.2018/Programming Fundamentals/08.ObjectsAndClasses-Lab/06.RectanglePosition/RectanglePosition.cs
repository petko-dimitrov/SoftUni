using System;
using System.Linq;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle firstRect = ReadRectangle();         
            Rectangle secondRect = ReadRectangle();
            bool isInside = firstRect.IsInside(secondRect);
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static Rectangle ReadRectangle()
        {
            int[] rectInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle()
            {
                Left = rectInfo[0],
                Bottom = rectInfo[1],
                Width = rectInfo[2],
                Height = rectInfo[3]
            };
            return rectangle;
        }
    }

    class Rectangle
    {
        public int Left { get; set; }
        public int Bottom { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Right
        {
            get
            {
                return Left + Width; 
            }
        }
        public int Top
        {
            get
            {
                return Bottom + Height;
            }
        }
        public bool IsInside(Rectangle rect)
        {
            return (Left >= rect.Left) && (Right <= rect.Right)
                && (Top <= rect.Top) && (Bottom <= rect.Bottom);
        }
    }
}
