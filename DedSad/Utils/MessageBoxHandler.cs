using System.Windows;

namespace DedSad.Utils
{
    public static class MessageBoxHandler
    {
        public static MessageBoxResult ShowMessageBoxError(string message)
        {
            return MessageBox.Show(message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static MessageBoxResult ShowMessageBoxInfo(string message)
        {
            return MessageBox.Show(message, "Результат!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static MessageBoxResult ShowMessageBoxQuestion(string message)
        {
            return MessageBox.Show(message, "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
