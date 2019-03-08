using integrationPaddle.PaddleIntegration;

namespace integrationPaddle
{
    public static class PaddleActionFactory
    {
        public static PaddleAction Create(Paddle paddle)
        {
            switch (paddle.alert_name)
            {
                case "subscription_created":
                    return new SubscriptionCreated(paddle);
                case "subscription_updated":
                    return new SubscriptionUpdated(paddle);
                case "subscription_cancelled":
                    return new SubscriptionCancelled(paddle);
                case "subscription_payment_succeeded":
                    return new SubscriptionPaymentSucceeded(paddle);
                case "subscription_payment_failed":
                    return new SubscriptionPaymentFailed(paddle);
                case "subscription_payment_refunded":
                    return new SubscriptionPaymentRefunded(paddle);
                default:
                    return null;
            }
        }
    }
}