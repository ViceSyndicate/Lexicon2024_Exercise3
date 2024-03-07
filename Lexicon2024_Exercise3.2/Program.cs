namespace Lexicon2024_Exercise3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>();

            NumericInputError numericInputError = new NumericInputError();
            errors.Add(numericInputError);

            TextInputError textInputError = new TextInputError();
            errors.Add(textInputError);

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            CastingError castingError = new CastingError();
            errors.Add(castingError);

            UnknownError unknownError = new UnknownError();
            errors.Add(unknownError);

            InheritanceError inheritanceError = new InheritanceError();
            errors.Add(inheritanceError);

            Console.WriteLine("------------------");
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
