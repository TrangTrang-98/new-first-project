using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class ExaminingForm : IAggregateRoot
    {
        public string ExFormID{get; set;}
        public string ExFormName{get; set;}
    }
}