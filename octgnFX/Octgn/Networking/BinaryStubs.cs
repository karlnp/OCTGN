﻿








/* 
 * This file was automatically generated by MyGeneration! (from BinarySender.zeus)
 * Do not modify, changes will get lost when the file is regenerated!
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Windows.Media;
using Octgn.Play;

namespace Octgn.Networking
{
	public abstract class BaseBinaryStub : IServerCalls
	{			
		protected abstract void Send(byte[] data);


		public void Binary()
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)0);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Error(string msg)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)1);
writer.Write(msg);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Hello(string nick, ulong pkey, string client, Version clientVer, Version octgnVer, Guid gameId, Version gameVersion, string password)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)2);
writer.Write(nick);
			writer.Write(pkey);
			writer.Write(client);
			writer.Write(clientVer.ToString());
			writer.Write(octgnVer.ToString());
			writer.Write(gameId.ToByteArray());
			writer.Write(gameVersion.ToString());
			writer.Write(password);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Settings(bool twoSidedTable)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)4);
writer.Write(twoSidedTable);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PlayerSettings(Player playerId, bool invertedTable)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)5);
writer.Write(playerId.Id);
			writer.Write(invertedTable);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void NickReq(string nick)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)8);
writer.Write(nick);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Start()
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)10);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void ResetReq()
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)11);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void NextTurn(Player nextPlayer)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)13);
writer.Write(nextPlayer.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void StopTurnReq(int turnNumber, bool stop)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)14);
writer.Write(turnNumber);
			writer.Write(stop);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void ChatReq(string text)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)16);
writer.Write(text);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PrintReq(string text)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)18);
writer.Write(text);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RandomReq(int id, int min, int max)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)20);
writer.Write(id);
			writer.Write(min);
			writer.Write(max);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RandomAnswer1Req(int id, ulong value)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)22);
writer.Write(id);
			writer.Write(value);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RandomAnswer2Req(int id, ulong value)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)24);
writer.Write(id);
			writer.Write(value);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CounterReq(Counter counter, int value)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)26);
writer.Write(counter.Id);
			writer.Write(value);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void LoadDeck(int[] id, ulong[] type, Group[] group)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)28);
writer.Write((short)id.Length);
foreach (int p in id)
	writer.Write(p);
			writer.Write((short)type.Length);
			foreach (ulong p in type)
				writer.Write(p);
			writer.Write((short)group.Length);
foreach (Group p in group)
	writer.Write(p.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CreateCard(int[] id, ulong[] type, Group group)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)29);
writer.Write((short)id.Length);
foreach (int p in id)
	writer.Write(p);
			writer.Write((short)type.Length);
			foreach (ulong p in type)
				writer.Write(p);
			writer.Write(group.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CreateCardAt(int[] id, ulong[] key, Guid[] modelId, int[] x, int[] y, bool faceUp, bool persist)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)30);
writer.Write((short)id.Length);
foreach (int p in id)
	writer.Write(p);
			writer.Write((short)key.Length);
			foreach (ulong p in key)
				writer.Write(p);
			writer.Write((short)modelId.Length);
foreach (Guid g in modelId)
	writer.Write(g.ToByteArray());
			writer.Write((short)x.Length);
foreach (int p in x)
	writer.Write(p);
			writer.Write((short)y.Length);
foreach (int p in y)
	writer.Write(p);
			writer.Write(faceUp);
			writer.Write(persist);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CreateAliasDeprecated(int[] id, ulong[] type)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)31);
writer.Write((short)id.Length);
foreach (int p in id)
	writer.Write(p);
			writer.Write((short)type.Length);
			foreach (ulong p in type)
				writer.Write(p);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void MoveCardReq(Card card, Group group, int idx, bool faceUp, bool isScriptMove)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)32);
writer.Write(card.Id);
			writer.Write(group.Id);
			writer.Write(idx);
			writer.Write(faceUp);
			writer.Write(isScriptMove);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void MoveCardAtReq(Card card, int x, int y, int idx, bool isScriptMove, bool faceUp)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)34);
writer.Write(card.Id);
			writer.Write(x);
			writer.Write(y);
			writer.Write(idx);
			writer.Write(isScriptMove);
			writer.Write(faceUp);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Reveal(Card card, ulong revealed, Guid guid)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)36);
writer.Write(card.Id);
			writer.Write(revealed);
			writer.Write(guid.ToByteArray());

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RevealToReq(Player sendTo, Player[] revealTo, Card card, ulong[] encrypted)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)37);
writer.Write(sendTo.Id);
			writer.Write((short)revealTo.Length);
foreach (Player p in revealTo)
	writer.Write(p.Id);
			writer.Write(card.Id);
			writer.Write((short)encrypted.Length);
			foreach (ulong p in encrypted)
				writer.Write(p);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PeekReq(Card card)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)39);
writer.Write(card.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void UntargetReq(Card card)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)41);
writer.Write(card.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void TargetReq(Card card)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)43);
writer.Write(card.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void TargetArrowReq(Card card, Card otherCard)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)45);
writer.Write(card.Id);
			writer.Write(otherCard.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Highlight(Card card, Color? color)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)47);
writer.Write(card.Id);
			writer.Write(color == null ? "" : color.ToString());

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void TurnReq(Card card, bool up)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)48);
writer.Write(card.Id);
			writer.Write(up);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RotateReq(Card card, CardOrientation rot)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)50);
writer.Write(card.Id);
			writer.Write((byte)rot);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void ShuffleDeprecated(Group group, int[] card)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)52);
writer.Write(group.Id);
			writer.Write((short)card.Length);
foreach (int p in card)
	writer.Write(p);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Shuffled(Group group, int[] card, short[] pos)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)53);
writer.Write(group.Id);
			writer.Write((short)card.Length);
foreach (int p in card)
	writer.Write(p);
			writer.Write((short)pos.Length);
foreach (short p in pos)
	writer.Write(p);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void UnaliasGrpDeprecated(Group group)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)54);
writer.Write(group.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void UnaliasDeprecated(int[] card, ulong[] type)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)55);
writer.Write((short)card.Length);
foreach (int p in card)
	writer.Write(p);
			writer.Write((short)type.Length);
			foreach (ulong p in type)
				writer.Write(p);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void AddMarkerReq(Card card, Guid id, string name, ushort count)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)56);
writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RemoveMarkerReq(Card card, Guid id, string name, ushort count)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)58);
writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void SetMarkerReq(Card card, Guid id, string name, ushort count)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)60);
writer.Write(card.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void TransferMarkerReq(Card from, Card to, Guid id, string name, ushort count)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)62);
writer.Write(from.Id);
			writer.Write(to.Id);
			writer.Write(id.ToByteArray());
			writer.Write(name);
			writer.Write(count);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PassToReq(ControllableObject id, Player to, bool requested)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)64);
writer.Write(id.Id);
			writer.Write(to.Id);
			writer.Write(requested);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void TakeFromReq(ControllableObject id, Player from)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)66);
writer.Write(id.Id);
			writer.Write(from.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void DontTakeReq(ControllableObject id, Player to)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)68);
writer.Write(id.Id);
			writer.Write(to.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void FreezeCardsVisibility(Group group)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)70);
writer.Write(group.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void GroupVisReq(Group group, bool defined, bool visible)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)71);
writer.Write(group.Id);
			writer.Write(defined);
			writer.Write(visible);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void GroupVisAddReq(Group group, Player who)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)73);
writer.Write(group.Id);
			writer.Write(who.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void GroupVisRemoveReq(Group group, Player who)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)75);
writer.Write(group.Id);
			writer.Write(who.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void LookAtReq(int uid, Group group, bool look)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)77);
writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(look);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void LookAtTopReq(int uid, Group group, int count, bool look)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)79);
writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(count);
			writer.Write(look);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void LookAtBottomReq(int uid, Group group, int count, bool look)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)81);
writer.Write(uid);
			writer.Write(group.Id);
			writer.Write(count);
			writer.Write(look);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void StartLimitedReq(Guid[] packs)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)83);
writer.Write((short)packs.Length);
foreach (Guid g in packs)
	writer.Write(g.ToByteArray());

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CancelLimitedReq()
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)85);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void CardSwitchTo(Player player, Card card, string alternate)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)87);
writer.Write(player.Id);
			writer.Write(card.Id);
			writer.Write(alternate);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PlayerSetGlobalVariable(Player player, string name, string val)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)88);
writer.Write(player.Id);
			writer.Write(name);
			writer.Write(val);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void SetGlobalVariable(string name, string val)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)89);
writer.Write(name);
			writer.Write(val);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Ping()
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)91);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void IsTableBackgroundFlipped(bool isFlipped)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)92);
writer.Write(isFlipped);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void PlaySound(Player player, string name)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)93);
writer.Write(player.Id);
			writer.Write(name);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void Ready(Player player)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)94);
writer.Write(player.Id);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}


		public void RemoteCall(Player player, string function, string args)
		{
		    if(Program.Client == null)return;
			MemoryStream stream = new MemoryStream(512);
			stream.Seek(4, SeekOrigin.Begin);
			BinaryWriter writer = new BinaryWriter(stream);

      if (Program.Client.Muted != 0)
          writer.Write(Program.Client.Muted);
      else
          writer.Write(0);
			writer.Write((byte)96);
writer.Write(player.Id);
			writer.Write(function);
			writer.Write(args);

			writer.Flush(); writer.Seek(0, SeekOrigin.Begin);
			writer.Write((int)stream.Length);
			writer.Close();
			Send(stream.ToArray());
		}

	}
	
	public class BinarySenderStub : BaseBinaryStub
	{
		private TcpClient to;
		
		public BinarySenderStub(TcpClient to)
		{ this.to = to; }
		
		protected override void Send(byte[] data)
		{
			try
			{
				Stream stream = to.GetStream();
				stream.Write(data, 0, data.Length); stream.Flush();
			}
			catch 
			{ 
				Program.Client.Disconnected();
			}
		}
	}
}
