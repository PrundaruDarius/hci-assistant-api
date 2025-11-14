using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HCI.AIAssistant.API.Models.DTOs.AIAssistantController;

namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    public async Task<ActionResult<AIAssistentControllerPostMessageResponseDTO>> PostMessageAsync([FromBody] AIAssistentControllerPostMessageRequestDTO requeste)
    {
        AIAssistentControllerPostMessageResponseDTO response = new()
        {
            TextMessage = "HI from AI Assistant!"
        };

        return Ok(response);
    }
}
