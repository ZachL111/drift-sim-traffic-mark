using DriftSimTrafficMark;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(69, 74, 27, 15, 9);
        if (Policy.Score(signalcase_1) != 89) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(63, 83, 13, 21, 4);
        if (Policy.Score(signalcase_2) != 93) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(74, 105, 22, 13, 11);
        if (Policy.Score(signalcase_3) != 168) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
