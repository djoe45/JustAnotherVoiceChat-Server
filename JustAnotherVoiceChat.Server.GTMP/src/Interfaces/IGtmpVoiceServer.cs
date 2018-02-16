﻿/*
 * File: IGtmpVoiceServer.cs
 * Date: 15.2.2018,
 *
 * MIT License
 *
 * Copyright (c) 2018 JustAnotherVoiceChat
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using GrandTheftMultiplayer.Server.Elements;
using JustAnotherVoiceChat.Server.Wrapper.Interfaces;

namespace JustAnotherVoiceChat.Server.GTMP.Interfaces
{
    public interface IGtmpVoiceServer : IVoiceServer
    {
        event GtmpVoiceDelegates.GtmpVoiceClientEvent OnClientPrepared;

        new event GtmpVoiceDelegates.GtmpVoiceClientEvent OnClientConnected;
        new event GtmpVoiceDelegates.GtmpVoiceClientEvent OnClientDisconnected;
        
        new event GtmpVoiceDelegates.GtmpVoiceClientStatusEvent OnClientTalkingChanged;
        
        IGtmpVoiceClient GetVoiceClient(Client player);

        void TriggerTalkingChangeEvent(ushort handle, bool newStatus);

        void TriggerOnClientConnectedEvent(ushort handle);
        void TriggerOnClientDisonnectedEvent(ushort handle);

    }
}
