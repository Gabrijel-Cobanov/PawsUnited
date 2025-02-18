using Ink.Runtime;
using UnityEngine;

public class InkTest : MonoBehaviour
{
    public TextAsset ink_json;
    private Story story;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        story = new Story(ink_json.text);
        story.BindExternalFunction("is_report_submitted", is_report_submitted);
        story.BindExternalFunction("is_clue_in_report", is_clue_in_report);
        Debug.Log(story.ContinueMaximally());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void is_report_submitted(){}

    void is_clue_in_report(){}
}
