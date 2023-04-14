 class CollisionManager
{
    public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    { 
        double sumWidth = Math.Abs(rectangle1.Width + rectangle2.Width)/2;
        double sumLeght = Math.Abs(rectangle1.Length + rectangle2.Length)/2;
        int dx = Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X);
        int dy = Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y);

        return dx< sumWidth && dy< sumLeght;
    }

    public bool IsCollision(Ring ring1, Ring ring2)
    {
        int forx = Math.Abs(ring1.Centre.X - ring2.Centre.X);
        int fory = Math.Abs(ring1.Centre.Y - ring2.Centre.Y);
        double c = Math.Sqrt(fory^2 + forx^2);

        return c < ring1.OuterRadius +ring2.OuterRadius;
    }
}
