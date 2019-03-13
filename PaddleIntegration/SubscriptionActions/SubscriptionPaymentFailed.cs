using integrationPaddle.PaddleIntegration;

namespace integrationPaddle.PaddleIntegration
{
    public class SubscriptionPaymentFailed : PaddleAction
    {
        public Paddle Paddle { get; private set; }
        public SubscriptionPaymentFailed(Paddle paddle)
        {
            Paddle = paddle;
        }
        public string Resolve()
        {
            return "SubscriptionPaymentFailed";
        }
    }
}