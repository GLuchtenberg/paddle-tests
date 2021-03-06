using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionUpdated : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionUpdated(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string Resolve()
        {
            return "SubscriptionUpdated";
        }
    }
}