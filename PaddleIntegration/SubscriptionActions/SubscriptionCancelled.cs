using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionCancelled : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionCancelled(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string resolve()
        {
            return "SubscriptionCancelled";
        }
    }
}