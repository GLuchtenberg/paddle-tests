using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionCreated : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionCreated(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string resolve()
        {
            return "SubscriptionCreated";
        }
    }
}