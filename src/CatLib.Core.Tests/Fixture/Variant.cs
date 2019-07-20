﻿/*
 * This file is part of the CatLib package.
 *
 * (c) CatLib <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: https://catlib.io/
 */

namespace CatLib.Tests.Fixture
{
    public class Variant
    {
        public Variant(VariantModel model)
        {
            Model = model;
        }

        public VariantModel Model { get; private set; }
    }
}
