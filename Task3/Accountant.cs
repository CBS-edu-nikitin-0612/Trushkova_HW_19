namespace Task3
{
    internal static class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            bool isGiven = false;

            if (Enum.TryParse(typeof(EnumPosition), worker.Position, true, out object? hourOfPosition))
            {
                if (hourOfPosition!= null && (int) hourOfPosition < hours)
                isGiven = true;
            }
            else throw new Exception("У сотрудника какая-то странная должность. Ее нет в нашей базе.");

            return isGiven;
        }
    }
}
