using DriftSimTrafficMark;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(40, 38, 17, 69);
        if (DomainReviewLens.Score(item) != 136) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "watch") throw new Exception("domain lane mismatch");
    }
}
