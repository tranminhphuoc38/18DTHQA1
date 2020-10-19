using _11_wpf_styles.Model;
using System.Collections.Generic;

namespace _11_wpf_styles {
    public class DataTemplateWindowViewModel {

        private List<string> m_fakeTexts = new List<string> {
            "Lorem Ipsum is simply dummy text.",
            "Contrary to popular belief."
        };

        public DataTemplateWindowViewModel() {
            Tasks = new List<TodoTask>();

            for (int i = 0; i < 10; i++) {
                Tasks.Add(new TodoTask {
                    TaskName = $"Todo Task {i}",
                    Description = m_fakeTexts[i % 2],
                    Priority = (i % 2) + 1
                });
            }
        }

        public List<TodoTask> Tasks { get; set; }
    }
}
