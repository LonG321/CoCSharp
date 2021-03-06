﻿using CoCSharp.Network;
using System;

namespace CoCSharp.Logic.Commands
{
    /// <summary>
    /// Command that is sent by the client to the server to tell
    /// it that a decoration was sold.
    /// </summary>
    public class SellDecorationCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellDecorationCommand"/> class.
        /// </summary>
        public SellDecorationCommand()
        {
            // Space
        }

        /// <summary>
        /// Gets the ID of the <see cref="SellDecorationCommand"/>.
        /// </summary>
        public override int ID { get { return 503; } }

        /// <summary>
        /// Game ID of the <see cref="Decoration"/> that was sold.
        /// </summary>
        public int DecorationGameID;

        /// <summary>
        /// Unknown integer 1.
        /// </summary>
        public int Unknown1;

        /// <summary>
        /// Reads the <see cref="SellDecorationCommand"/> from the specified <see cref="MessageReader"/>.
        /// </summary>
        /// <param name="reader">
        /// <see cref="MessageReader"/> that will be used to read the <see cref="SellDecorationCommand"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="reader"/> is null.</exception>
        public override void ReadCommand(MessageReader reader)
        {
            ThrowIfReaderNull(reader);

            DecorationGameID = reader.ReadInt32();

            Unknown1 = reader.ReadInt32();
        }

        /// <summary>
        /// Writes the <see cref="SellDecorationCommand"/> to the specified <see cref="MessageWriter"/>.
        /// </summary>
        /// <param name="writer">
        /// <see cref="MessageWriter"/> that will be used to write the <see cref="SellDecorationCommand"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="writer"/> is null.</exception>
        public override void WriteCommand(MessageWriter writer)
        {
            ThrowIfWriterNull(writer);

            writer.Write(DecorationGameID);

            writer.Write(Unknown1);
        }
    }
}
