public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data)
        {
            Console.WriteLine("Duplicate");
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        var toreturn = true;
        if (value < Data)
        {
            // Check to the left
            if (Left is null)
            {
                toreturn = false;
            }

            else
                toreturn = Left.Contains(value);
        }
        if (value > Data)
        {
            // Check to the right
            if (Right is null)
            {
                toreturn = false;
            }

            else
                toreturn = Right.Contains(value);
        }
        return toreturn;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        var total = 0;

        if (Left is null && Right is null)
        {
            total = 0;
        }
        if (Left is null && Right is not null)
        {
            total = Right.GetHeight();
        }
        if (Left is not null && Right is null)
        {
            total = Left.GetHeight();
        }
        if (Left is not null && Right is not null)
        {
            var right = Right.GetHeight();
            var left = Left.GetHeight();

            if (right >= left)
            {
                total = right;
            }
        }
        return total + 1; // Replace this line with the correct return statement(s)
    }
}