using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionPaymentRefunded : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionPaymentRefunded(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string Resolve()
        {
            return "SubscriptionPaymentRefunded";
        }
    }
}