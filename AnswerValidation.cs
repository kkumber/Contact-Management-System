using System;

namespace ContactManagementSystem
{
    class AnswerValidation
    {
        public static bool IsValidMainMenuNavigationAnswer(char answer)
        {
            return answer == '1' || answer == '2' || answer == '3' || answer == '4' || answer == '5' || answer == '6';
        }

        public static bool IsOneOrTwo(char answer)
        {
            return answer == '1' || answer == '2';
        }

        public static bool IsValidContactDetailsNavigationAnswer(char answer) 
        {
            return answer == '1' || answer == '2' || answer == '0';
        }
    }
}
