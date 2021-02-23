using Application;
using Domain;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation
{
    public class CounterView : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Text countNumText;
        private CounterApplicationService _counterApplicationService;

        // Start is called before the first frame update
        private void Start()
        {
            _counterApplicationService = new CounterApplicationService();
            InitializeCounter();
        }

        private void InitializeCounter()
        {
            var count = _counterApplicationService.GetCurrentCount();
            UpdateCountNumText(count);
            button.onClick.AddListener(IncrementCount);
        }

        private void IncrementCount()
        {
            var count = _counterApplicationService.CountUp();
            UpdateCountNumText(count);
        }

        private void UpdateCountNumText(Count count)
        {
            countNumText.text = count.Value.ToString();
        }
    }
}
