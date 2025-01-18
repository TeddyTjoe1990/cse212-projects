public static class MysteryStack2
{
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) {
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Not enough operands for operation.");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+")
                    res = op1 + op2;
                else if (item == "-")
                    res = op1 - op2;
                else if (item == "*")
                    res = op1 * op2;
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Division by zero is not allowed.");
                    res = op1 / op2;
                }

                stack.Push(res);
            } else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            } else {
                throw new ApplicationException($"Invalid token in input: {item}");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("The input expression is invalid.");

        return stack.Pop();
    }
}
