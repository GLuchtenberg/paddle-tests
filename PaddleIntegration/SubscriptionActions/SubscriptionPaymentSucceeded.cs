using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionPaymentSucceeded : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionPaymentSucceeded(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string resolve()
        {
            return "SubscriptionPaymentSucceeded";
        }
    }
}