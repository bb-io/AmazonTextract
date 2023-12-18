using Amazon.Textract.Model;
using Apps.AmazonTextract.Models.Entities;

namespace Apps.AmazonTextract.Models.Response;

public class BlocksResponse
{
    public IEnumerable<BlockEntity> Blocks { get; set; }
    public BlocksResponse(List<Block> blocks)
    {
        Blocks = blocks.Select(x => new BlockEntity(x));
    }
}